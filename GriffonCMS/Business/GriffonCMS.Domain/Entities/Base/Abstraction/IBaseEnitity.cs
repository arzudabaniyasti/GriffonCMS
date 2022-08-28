namespace GriffonCMS.Domain.Entities.Base.Abstraction;
public interface IBaseEnitity<TPK>
{
    public TPK Id { get; set; }
}
