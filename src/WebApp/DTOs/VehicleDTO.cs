﻿namespace Pitstop.WebApp.DTOs;

public class VehicleDTO {
    public string LicenseNumber { get; set; }

    public string Brand { get; set; }

    public string Type { get; set; }

    public string OwnerId { get; set; }

    public Boolean HasMaintenanceHistory { get; set; }
}