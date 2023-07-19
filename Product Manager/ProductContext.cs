using Microsoft.EntityFrameworkCore;

namespace Product_Manager;

public class ProductContext : DbContext {
    public ProductContext() : base() {
    }

    public virtual DbSet<Product> Products { get; set; }

}