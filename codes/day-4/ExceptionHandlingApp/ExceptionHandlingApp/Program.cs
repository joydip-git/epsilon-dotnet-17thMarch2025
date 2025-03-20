namespace ExceptionHandlingApp
{
    internal class Program
    {
        static int? Divide(int a, int b)
        {
            try
            {
                if (b > 0)
                {
                    int res = a / b;
                    return res;
                }
                else
                    return null;
            }
            catch (DivideByZeroException)
            {
                throw;
            }
            catch (Exception)
            {
                throw;
            }
            //try to use above code as compared to the following code, as it will NOT alter the actual stack trace information
            //catch (DivideByZeroException ex)
            //{
            //    throw ex;
            //}
            //catch (Exception ex)
            //{
            //    throw ex;
            //}
        }
        static void Main(string[] args)
        {
            //int x = 10;
            //int y = 0;
            int? z = null;

            //public void TryError()
            try
            {
                //z = x / y;
                z = Divide(1, 0);
            }
            //public void Catch(DivideByZeroException ex)
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Class: {ex.GetType().FullName}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"App: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine($"Class: {ex.GetType().FullName}");
                Console.WriteLine($"Method: {ex.TargetSite}");
                Console.WriteLine($"App: {ex.Source}");
                Console.WriteLine($"Details: {ex.StackTrace}");
            }
            finally
            {
                if (!z.HasValue || z.Value == 0)
                    Console.WriteLine("could not divide");
                else
                    Console.WriteLine(z.Value);
            }
        }
    }
}
