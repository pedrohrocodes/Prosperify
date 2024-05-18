using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Notifications;

public class Notify
{
    public Notify()
    {
        this.Notifications = new List<Notify>();
    }
    
    public Notify(string propertyName, string message)
    {
        this.PropertyName = propertyName;
        this.Message = message;
        this.Notifications = new List<Notify>();
    }

    [NotMapped] 
    public string PropertyName { get; }
    
    [NotMapped] 
    public string Message { get; }
    
    [NotMapped] 
    public List<Notify> Notifications;

    public bool ValidateStringProperty(string value, string propertyName)
    {
        if (string.IsNullOrWhiteSpace(value) || string.IsNullOrWhiteSpace(propertyName))
        {
            this.Notifications.Add(new Notify("Campo Obrigatório", propertyName));

            return false;
        }

        return true;
    }

    public bool ValidateIntProperty(int value, string propertyName)
    {
        if (value < 1 || string.IsNullOrWhiteSpace(propertyName))
        {
            this.Notifications.Add(new Notify("Campo Obrigatório", propertyName));
        }

        return true;
    }
}