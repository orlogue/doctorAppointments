using domain.Logic;
namespace domain.Classes;

public class Appointment
{
    public Int64 Id { get; set; }
    public Int64 PatientId { get; set; }
    public int DoctorId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }

    public Appointment() : this(0, 0, 0, DateTime.MinValue, DateTime.MinValue) {}

    public Appointment(Int64 id, Int64 patientId, int doctorId, DateTime startTime,
        DateTime endTime)
    {
        Id = id;
        PatientId = patientId;
        DoctorId = doctorId;
        StartTime = startTime;
        EndTime = endTime;
    }

    public Result IsValid()
    {
        if (Id < 0)
            return Result.Fail("Invalid id");

        if (PatientId < 0)
            return Result.Fail("Invalid patient id");
        
        if (DoctorId < 0)
            return Result.Fail("Invalid doctor id");

        if (StartTime > EndTime)
            return Result.Fail("Invalid time");

        return Result.Ok();
    }
}