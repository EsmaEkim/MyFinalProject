using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Produkt hinzugefügt";
        public static string ProductUpdated = "Produkt aktualisiert";
        public static string ProductNameInvalid = "Produktname ungültig";
        public static string MaintenanceTime = "Systemwartung";
        public static string ProductsListed = "Produkte aufgelistet";

        public static string CategoryAdded = "Die Kategorie wurde hinzugefügt";
        public static string CategoryDeleted = "Die Kategorie wurde gelöscht";
        public static string CategoryUpdated = "Die Kategorie wurde aktualisiert";
        public static string CategoryListed = "Die Kategorien wurden aufgelistet";

        public static string ProductCountOfCategoryError = "In einer Kategorie können maximal 10 Produkte sein.";
        public static string ProductNameAlreadyExists = "Unter diesem Namen gibt es schon ein anderes Produkt.";
        public static string CategoryLimitExceded = "Wegen der Überschreitung des Kategorienlimits können keine neuen Produkte hinzugefügt werden.";
        public static string AuthorizationDenied = "Sie haben keine Autorität.";
        public static string UserRegistered = "Benutzer wurde registriert.";
        public static string UserNotFound = "Benutzer nicht gefunden.";
        public static string PasswordError= "Falsches Passwort.";
        public static string SuccessfulLogin= "Erfolgreiche Anmeldung.";
        public static string UserAlreadyExists= "Benutzer ist bereits vorhanden.";
        public static string AccessTokenCreated= "Token wurde erstellt.";
    }
}
