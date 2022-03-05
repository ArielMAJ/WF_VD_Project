using System;
using WF_VD_Project.DataBase;
using WF_VD_Project.Entities.Exceptions;
using System.Data;

namespace WF_VD_Project.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string JobTitle { get; set; }
        public ListBox.ObjectCollection AssociatedEquipments { get; set; }

        public Client(string name, string cpf, string jobTitle, ListBox.ObjectCollection associatedEquipments)
        {
            if (string.IsNullOrEmpty(name)) { throw new DomainException("Cliente deve ter nome."); }
            if (string.IsNullOrEmpty(cpf)) { throw new DomainException("Cliente deve ter CPF."); }
            if (cpf.All(x => !char.IsDigit(x))) { throw new DomainException("CPF deve ter apenas números."); }
            if (cpf.Length != 11) { throw new DomainException("CPF deve ter 11 dígitos."); }

            Name = name;
            CPF = cpf;
            JobTitle = jobTitle;
            AssociatedEquipments = associatedEquipments;
        }


        public void SaveToDB()
        // Saves client to CLIENTS table in the database.
        {
            // Inserting client into DB Clients table.
            DB.consult(
                "INSERT INTO CLIENTS(T_NAME,T_CPF,T_JOBTITLE)" +
                $"VALUES('{Name}', '{CPF}','{JobTitle}') "
            );


            // Getting Client ID after insertion.
            string clientID = DB.consult(
                $"SELECT IDCLIENT FROM CLIENTS WHERE " +
                $"  T_NAME='{Name}' AND " +
                $"  T_CPF='{CPF}' AND " +
                $"  T_JOBTITLE='{JobTitle}'"
            ).Rows[0].Field<Int64>("IDCLIENT").ToString();


            // Associating equipments to client ID in EQUIPMENTS table.
            foreach (string equipment in AssociatedEquipments)
            {
                DB.consult(
                    $"UPDATE EQUIPMENTS SET " +
                    $"  ID_CLIENT={clientID} " +
                    $"WHERE ID_CLIENT IS NULL AND IDEQUIPMENT={equipment.Split(" ")[0]}"
                );
            }
        }

        public void UpdateInDB(string clientID)
        // Updates client to CLIENTS table in the database.
        {
            // Updating client information
            DB.consult(
                $"UPDATE CLIENTS SET " +
                $"  T_NAME = '{Name}', " +
                $"  T_CPF = '{CPF}', " +
                $"  T_JOBTITLE = '{JobTitle}' " +
                $"WHERE IDCLIENT = {clientID};"
            );

            // Disassociating every equipment associated to this client
            DB.consult(
                $"UPDATE EQUIPMENTS SET " +
                $"  ID_CLIENT=NULL " +
                $"WHERE ID_CLIENT = {clientID}"
            );

            // Associating to this client the new selected equipments
            foreach (string equipment in AssociatedEquipments)
            {
                DB.consult(
                    $"UPDATE EQUIPMENTS SET " +
                    $"  ID_CLIENT={clientID} " +
                    $"WHERE ID_CLIENT IS NULL AND IDEQUIPMENT={equipment.Split(" ")[0]}"
                );
            }
        }

        public void DeleteFromDB(string clientID)
        // Deletes client from CLIENTS table in the database.
        {
            DB.consult(
                        $"DELETE FROM CLIENTS " +
                        $"WHERE IDCLIENT = {clientID};"
                    );


            foreach (string equipment in AssociatedEquipments)
            {
                DB.consult(
                    $"UPDATE EQUIPMENTS SET " +
                    $"ID_CLIENT=NULL " +
                    $"WHERE ID_CLIENT = {clientID};"
                );
            }
        }
    }
}
