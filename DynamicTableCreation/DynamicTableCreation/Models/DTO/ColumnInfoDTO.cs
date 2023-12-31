﻿namespace DynamicTableCreation.Models.DTO
{
    public class ColumnInfoDTO
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public string keyType { get; set; }

        public string foreignKey { get; set; }

        public string HostName { get; set; }
        public string DatabaseName { get; set; }
    }
}
