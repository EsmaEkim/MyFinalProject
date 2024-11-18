using Entities.Concrete;
using System;
using System.Collections.Generic;
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
        public static string ProductCountOfCategoryError="In einer Kategorie können maximal 10 Produkte sein.";
    }
}
