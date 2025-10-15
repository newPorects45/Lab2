using System;
using System.Collections.Generic;
using System.Linq; 

namespace HospitalManagementSystem
{
    public class HospitalDemo
    {
        public void Run()
        {
            
            Console.WriteLine("=== СИСТЕМА УПРАВЛІННЯ ЛІКАРНЕЮ ===\n");

            
            Hospital hospital = new Hospital();

         
            Doctor doctor1 = new Doctor(1, "Іванов Іван", "Терапевт");
            hospital.AddDoctor(doctor1); 

           
            Patient patient1 = new Patient(1, "Коваленко Тарас", 30);
            hospital.RegisterPatient(patient1); 

           
            HospitalRoom room1 = new HospitalRoom(101, 1);
            hospital.CreateRoom(room1);

            
            hospital.HospitalizePatient(1, 101); 

          
            MedicalRecord record1 = new MedicalRecord(patient1, doctor1, DateTime.Now, "Перевірка");
            hospital.AddMedicalRecord(record1); 

           
            Console.WriteLine("\n--- ІСТОРІЯ ПАЦІЄНТА ---");
            var history = hospital.GetPatientHistory(1);
            foreach (var record in history) 
            {
                Console.WriteLine($"  Дата: {record.Date.ToShortDateString()}"); 
                Console.WriteLine($"  Лікар: {record.Doctor.Name}");
                Console.WriteLine($"  Опис: {record.Description}\n"); 
            }

           
            Console.WriteLine(hospital.GetStatistics());
        }
    }
}