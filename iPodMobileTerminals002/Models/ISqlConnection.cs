using System;
using SQLite;

namespace iPodMobileTerminals002.Models
{
    public interface ISqlConnection
    {
        SQLiteAsyncConnection Connection();
    }
}
