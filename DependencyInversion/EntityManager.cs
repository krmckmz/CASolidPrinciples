public class EntityManager
{
    private readonly IEntityRepository _entityRepository;

    public EntityManager(IEntityRepository entityRepository)
    {
        _entityRepository = entityRepository;
    }

    public Entity Get(int id)
    {
        return _entityRepository.Get();
    }

    public void Add(Entity entity)
    {
        _entityRepository.Add(entity);
    }

    public void Update(Entity entity)
    {
        _entityRepository.Update(entity);
    }

    public void Remove(int id)
    {
        _entityRepository.Remove(id);
    }

}