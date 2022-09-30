public class Instrument {
    private string Stringtype;
    private string Bodytype;
    private string Serialnumber;
   
    

    public Instrument(string Stringtype ,
    string Bodytype,
     string Serialnumber) {
        this.Stringtype = Stringtype;
        this.Bodytype = Bodytype; 
        this.Serialnumber = Serialnumber;
     }

    public string GetString() {
        return this.Stringtype;
    }

    public string GetBody() {
        return this.Bodytype;
    }

    public string GetSerialnymber() {
        return this.Serialnumber;
    }

}