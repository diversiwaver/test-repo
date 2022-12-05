using AutoMapper;

namespace Tools;
public static class DtoConverter<T, U>
{
    //using automapper to map model objects to a DTO.
    private static MapperConfiguration config = new(cfg =>
    {
        cfg.CreateMap<T, U>();
    });
    private static Mapper mapper = new(config);


    //Mathod for mapping a single model object to DTO and viceversa
    // T - original object type
    // U - target object type
    public static U From(T sourceObject) => mapper.Map<T, U>(sourceObject);

    //Converting a collection
    public static IEnumerable<U> FromList(IEnumerable<T> sourceList) => sourceList.ToList().Select(obj => From(obj));
}

