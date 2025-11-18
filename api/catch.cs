try
{

}
catch (FormatException ex)
{

}
catch (OverflowException)
{

}
catch (Exception ex)
{

}
finally
{

}


public class Examples
{
    string input = "123";

    public Examples()
    {

    }

    public void Catch()
    {
        try
        {
            int num_int = int.Parse(input);
            double num_duble = double.Parse(input);
            string str = num_int.ToString();
        }
        catch (Exception ex)
        {
            System.Console.WriteLine($"Err type: {ex.GetType().Name}");
            System.Console.WriteLine($"Msg: {ex.Message}");
            return;
        }
        finally
        {
            System.Console.WriteLine("Finally run always (Err or Ok)");
        }


        try
        {
            string? read_user = Console.ReadLine();
            if (read_user is null) { return; }
            int val = int.Parse(read_user);
        }
        catch (FormatException ex)
        {
            System.Console.WriteLine($"{ex}");
        }


        try
        {

        }
        catch (FormatException ex)
        {
            MessageBox.Show($"[Err]: conexión sql. {ex}");
            return;
        }



        try
        {

        }
        catch (FormatException ex)
        {
            throw new Exception($"[Something went wrong!]: {ex}");
        }

    }
}
