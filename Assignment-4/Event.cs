using System;

class Button
{
    public event Action OnClick;

    public void Press()
    {
        if (OnClick != null)
        {
            OnClick();
        }
    }
}

class Program
{
    static void Main()
    {
        Button btn = new Button();
        btn.OnClick += TurnOnLight;
        btn.Press();
    }

    static void TurnOnLight()
    {
        Console.WriteLine("The light is now on.");
    }
}
