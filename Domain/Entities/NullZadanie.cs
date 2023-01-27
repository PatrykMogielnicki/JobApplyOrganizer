namespace Domain.Entities
{
    public class NullZadanie : IZadanie
    {
        public Guid Guid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Color Color { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Description { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public PriorityLevel Priority { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public List<DateTime> Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Checked { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public Stage Stan { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FileName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
