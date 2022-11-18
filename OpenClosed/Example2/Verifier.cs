protected abstract class Verifier<T>
{
    protected abstract bool IsValid(T t);
        protected abstract bool IsValidZipCode(int zipCode);

}