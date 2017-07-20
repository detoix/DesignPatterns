namespace SimpleFactory.Items
{
    public interface IItem
    {
        int IntParameter { get; set; }
        string StringParameter { get; set; }
        void SampleMethod();
    }
}
