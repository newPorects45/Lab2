using System;

namespace HospitalManagementSystem
{
    public class MedicalRecord // додаємо public
    {
        public Patient Patient { get; set; } // додаємо public властивості
        public Doctor Doctor { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }

        public MedicalRecord(Patient patient, Doctor doctor, DateTime date, string description) // конструктор
        {
            Patient = patient;
            Doctor = doctor;
            Date = date;
            Description = description;
        }
    }
}