namespace MatrixMutator
{
    public static class MatrixLoader
    {
        public static List<float?> LoadMatrix(string path)
        {
            var matrix = new List<float?>();
            using StreamReader reader = new(path);
            while(reader.Peek() >= 0)
            {
                var row = reader.ReadLine()
                    ?.Split(',')
                    .Select(s => float.TryParse(s, out float f) ? f : default(float?))
                    ?? throw new InvalidOperationException();
                matrix.AddRange(row);
            }
            return matrix;
        }
    }
}
