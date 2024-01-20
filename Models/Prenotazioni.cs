public class Prenotazioni{

    public string? Nome { get; set; } required
    public string? Cognome { get; set; }required
    public string? Email { get; set; }required
    public  DateTime DataDiNascita { get; set; }required
    public Sesso sesso { get; set; }
    public Ruolo ruolo { get; set; }

    public enum Sesso{
        M,
        F,
        NoSpecificato,
    }

    public enum Ruolo{
        Insegnante,
        Genitore,
        Studente,
    }


}