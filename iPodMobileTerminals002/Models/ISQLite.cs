using System;
using System.Collections.Generic;
using SQLite;

namespace iPodMobileTerminals002.Models
{
    public interface ISQLite
    {
        SQLiteConnection GetConnectionWithCreateDatabase();

        bool SaveMajorCategory(MajorCategory major);
        List<MajorCategory> GetMajorCategory();
    }
}
