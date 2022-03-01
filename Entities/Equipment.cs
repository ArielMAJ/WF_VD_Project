﻿using System;
using WF_VD_Project.DataBase;
using WF_VD_Project.Entities.Exceptions;

namespace WF_VD_Project.Entities
{
    internal class Equipment
    {
        public string Description { get; set; }
        public string AssociatedClientID { get; set; }

        public Equipment(string description, string associatedClientID)
        {
            if (string.IsNullOrEmpty(description)) { throw new DomainException("Equipamento deve ter descrição."); }

            Description = description;
            AssociatedClientID = associatedClientID;
        }

        public void SaveToDB()
        {
            DB.consult(
                $"INSERT INTO EQUIPMENTS(T_EQUIPMENTDESCRIPTION,ID_CLIENT) " +
                $"VALUES('{Description}', {AssociatedClientID});"
            );
        }

        public void UpdateInDB(string equipmentID)
        {
            DB.consult(
                $"UPDATE EQUIPMENTS SET " +
                $"  T_EQUIPMENTDESCRIPTION = '{Description}', " +
                $"  ID_CLIENT = {AssociatedClientID} " +
                $"WHERE IDEQUIPMENT = {equipmentID};"
            );
        }
        public static void DeleteFromDB(string equipmentID)
        {
            DB.consult(
                        $"DELETE FROM EQUIPMENTS " +
                        $"WHERE IDEQUIPMENT = {equipmentID};"
            );
        }
    }
}
