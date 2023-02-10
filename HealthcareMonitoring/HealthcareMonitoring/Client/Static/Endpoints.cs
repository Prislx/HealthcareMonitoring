using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthcareMonitoring.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";

        public static readonly String AppointmentsEndpoint = $"{Prefix}/appointments";
        public static readonly String DiagnosesEndpoint = $"{Prefix}/diagnoses";
        public static readonly String MedicinesEndpoint = $"{Prefix}/medicines";
        public static readonly String PrescMedsEndpoint = $"{Prefix}/prescmeds";
        public static readonly String PrescriptionsEndpoint = $"{Prefix}/prescriptions";
        public static readonly String StaffsEndpoint = $"{Prefix}/staffs";
        public static readonly String PatientsEndpoint = $"{Prefix}/patients";
    }
}
