﻿using System;

namespace PharmacyManager.Shared.Entities
{
    public class Medicament
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Manufacturer { get; set; }

        public DateTime ReceiptDate { get; set; }

        public bool IsAvailable { get; set; }
    }
}
