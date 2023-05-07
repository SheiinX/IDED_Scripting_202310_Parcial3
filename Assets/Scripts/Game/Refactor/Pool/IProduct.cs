public interface IProduct
{
    public string ProductName { get; set; }

    // customize this for each concrete product
    public void Initialize();
}
