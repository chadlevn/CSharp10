namespace NullWarnings
{
    public class Class1
    {
        public void Method()
        {
            var c = new Class1();
            string representation = "N/A";
            if ((c != null && c.GetDependentValue(out object obj)) == true)
            {
                representation = obj.ToString(); // undesired error
            }

            // Or, using ?.
            if (c?.GetDependentValue(out object obj) == true)
            {
                representation = obj.ToString(); // undesired error
            }

            // Or, using ??
            if (c?.GetDependentValue(out object obj) ?? false)
            {
                representation = obj.ToString(); // undesired error
            }
        }

        private bool GetDependentValue(out object obj)
        {
            throw new NotImplementedException();
        }
    }
}