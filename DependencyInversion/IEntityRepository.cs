public interface IEntityRepository
{
    Entity Get(int id);
    void Add(Entity entity);
    void Update(Entity entity);
    void Remove(int id);
}