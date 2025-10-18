using ACS.Classes;
using System;
using System.Data;
using System.Data.SqlClient;

namespace NormacApp.Models
{
    public class hr_employee
    {
        // --- Propiedades ---
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public bool Active { get; set; }
        public int AddressHomeId { get; set; }
        public int CountryId { get; set; }
        public string Gender { get; set; }
        public string Marital { get; set; }
        public string SpouseCompleteName { get; set; }
        public string SpouseBirthdate { get; set; }
        public int Children { get; set; }
        public string PlaceOfBirth { get; set; }
        public string CountryOfBirth { get; set; }
        public string Birthday { get; set; }
        public string IdentificationId { get; set; }
        public string PassportId { get; set; }
        public string AdditionalNote { get; set; }
        public string Certificate { get; set; }
        public string StudyField { get; set; }
        public string StudySchool { get; set; }
        public string EmergencyContact { get; set; }
        public string EmergencyPhone { get; set; }
        public int KmHomeWork { get; set; }
        public string JobTitle { get; set; }
        public int AddressId { get; set; }
        public string WorkPhone { get; set; }
        public string MobilePhone { get; set; }
        public string WorkEmail { get; set; }
        public string WorkLocation { get; set; }
        public int JobId { get; set; }
        public int DepartmentId { get; set; }
        public int ParentId { get; set; }
        public int CompanyId { get; set; }
        public int CreateUid { get; set; }
        public string CreateDate { get; set; }
        public string Barcode { get; set; }
        public int Manager { get; set; }
        public DateTime? MedicExam { get; set; }   // tipo DATE
        public int ProfessionId { get; set; }
        public string PaymentType { get; set; }
        public string College { get; set; }
        public string Rtn { get; set; }
        public string BloodType { get; set; }
        public string EmployeeAccount { get; set; }
        public int BankId { get; set; }
        public int RollTypeId { get; set; }
        public string ShirtSize { get; set; }
        public string PantSize { get; set; }
        public string ShoeSize { get; set; }
        public decimal Height { get; set; }
        public decimal Weight { get; set; }
        public string Marking { get; set; }
        public int IdGrupo { get; set; }
        public string XHourIn { get; set; }
        public string XHourOut { get; set; }
        public int XConfAplic { get; set; }
        public int XIdJournal { get; set; }
        public int IdTipoSeguro { get; set; }
        public int CompanyAddressId { get; set; }
        public int HrCompanyAddressPhoneId { get; set; }
        public int BandaSalarialId { get; set; }
        public int DependientesCant { get; set; }
        public int IdNivelCertificadoEstudio { get; set; }
        public int IdAmbitoEstudio { get; set; }
        public int IdEscuelaUniversidad { get; set; }
        public int IdTipoPago { get; set; }
        public decimal DepreciacionVehicular { get; set; }
        public int IdVehiculo { get; set; }
        public bool AplicaIsr { get; set; }
        public bool EsDiscapacitado { get; set; }
        public string Discapacidad { get; set; }
        public string NumeroPermisoTrabajo { get; set; }
        public bool PagaPorDependientes { get; set; }
        public int ResourceCalendarId { get; set; }
        public string PrivateEmail { get; set; }
        public bool Recuperado { get; set; }    

        public hr_employee() { }


        // --- Cadena de conexión (ajústala a tu entorno) ---
        private string connectionString = "";

        // --- Método para obtener empleado por ID ---
        public bool GetById(int id)
        {
            bool found = false;
            Recuperado = false;
            DataOperations dp = new DataOperations();
            connectionString = dp.ConnectionStringJAGUAR_DB;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand("sp_GetEmployeeById", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@id", id);
                    conn.Open();

                    using (SqlDataReader r = cmd.ExecuteReader())
                    {
                        if (r.Read())
                        {
                            Recuperado = found = true;

                            Id = Convert.ToInt32(r["id"]);
                            Name = r["name"].ToString();
                            UserId = Convert.ToInt32(r["user_id"]);
                            Active = Convert.ToBoolean(r["active"]);
                            AddressHomeId = Convert.ToInt32(r["address_home_id"]);
                            CountryId = Convert.ToInt32(r["country_id"]);
                            Gender = r["gender"].ToString();
                            Marital = r["marital"].ToString();
                            SpouseCompleteName = r["spouse_complete_name"].ToString();
                            SpouseBirthdate = r["spouse_birthdate"].ToString();
                            Children = Convert.ToInt32(r["children"]);
                            PlaceOfBirth = r["place_of_birth"].ToString();
                            CountryOfBirth = r["country_of_birth"].ToString();
                            Birthday = r["birthday"].ToString();
                            IdentificationId = r["identification_id"].ToString();
                            PassportId = r["passport_id"].ToString();
                            AdditionalNote = r["additional_note"].ToString();
                            Certificate = r["certificate"].ToString();
                            StudyField = r["study_field"].ToString();
                            StudySchool = r["study_school"].ToString();
                            EmergencyContact = r["emergency_contact"].ToString();
                            EmergencyPhone = r["emergency_phone"].ToString();
                            KmHomeWork = Convert.ToInt32(r["km_home_work"]);
                            JobTitle = r["job_title"].ToString();
                            AddressId = Convert.ToInt32(r["address_id"]);
                            WorkPhone = r["work_phone"].ToString();
                            MobilePhone = r["mobile_phone"].ToString();
                            WorkEmail = r["work_email"].ToString();
                            WorkLocation = r["work_location"].ToString();
                            JobId = Convert.ToInt32(r["job_id"]);
                            DepartmentId = Convert.ToInt32(r["department_id"]);
                            ParentId = Convert.ToInt32(r["parent_id"]);
                            CompanyId = Convert.ToInt32(r["company_id"]);
                            CreateUid = Convert.ToInt32(r["create_uid"]);
                            CreateDate = r["create_date"].ToString();
                            Barcode = r["barcode"].ToString();
                            Manager = Convert.ToInt32(r["manager"]);

                            MedicExam = r["medic_exam"] != DBNull.Value
                                ? Convert.ToDateTime(r["medic_exam"])
                                : (DateTime?)null;

                            ProfessionId = Convert.ToInt32(r["profession_id"]);
                            PaymentType = r["payment_type"].ToString();
                            College = r["college"].ToString();
                            Rtn = r["rtn"].ToString();
                            BloodType = r["blood_type"].ToString();
                            EmployeeAccount = r["employee_account"].ToString();
                            BankId = Convert.ToInt32(r["bank_id"]);
                            RollTypeId = Convert.ToInt32(r["roll_type_id"]);
                            ShirtSize = r["shirt_size"].ToString();
                            PantSize = r["pant_size"].ToString();
                            ShoeSize = r["shoe_size"].ToString();
                            Height = Convert.ToDecimal(r["height"]);
                            Weight = Convert.ToDecimal(r["weight"]);
                            Marking = r["marking"].ToString();
                            IdGrupo = Convert.ToInt32(r["id_grupo"]);
                            XHourIn = r["x_hour_in"].ToString();
                            XHourOut = r["x_hour_out"].ToString();
                            XConfAplic = Convert.ToInt32(r["x_conf_aplic"]);
                            XIdJournal = Convert.ToInt32(r["x_id_journal"]);
                            IdTipoSeguro = Convert.ToInt32(r["id_tipo_seguro"]);
                            CompanyAddressId = Convert.ToInt32(r["company_address_id"]);
                            HrCompanyAddressPhoneId = Convert.ToInt32(r["hr_company_address_phone_id"]);
                            BandaSalarialId = Convert.ToInt32(r["banda_salarial_id"]);
                            DependientesCant = Convert.ToInt32(r["dependientes_cant"]);
                            IdNivelCertificadoEstudio = Convert.ToInt32(r["id_nivel_certificado_estudio"]);
                            IdAmbitoEstudio = Convert.ToInt32(r["id_ambito_estudio"]);
                            IdEscuelaUniversidad = Convert.ToInt32(r["id_escuela_universidad"]);
                            IdTipoPago = Convert.ToInt32(r["id_tipo_pago"]);
                            DepreciacionVehicular = Convert.ToDecimal(r["depreciacion_vehicular"]);
                            IdVehiculo = Convert.ToInt32(r["id_vehiculo"]);
                            AplicaIsr = Convert.ToBoolean(r["aplica_isr"]);
                            EsDiscapacitado = Convert.ToBoolean(r["es_discapacitado"]);
                            Discapacidad = r["discapacidad"].ToString();
                            NumeroPermisoTrabajo = r["numero_permiso_trabajo"].ToString();
                            PagaPorDependientes = Convert.ToBoolean(r["paga_por_dependientes"]);
                            ResourceCalendarId = Convert.ToInt32(r["resource_calendar_id"]);
                            PrivateEmail = r["private_email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                CajaDialogo.Error("Error al recuperar empleado: " + ex.Message);
            }

            return found;
        }

        public bool TieneHuella(int pdedo, object idEstudiante)
        {
            return false;
        }
    }
}

