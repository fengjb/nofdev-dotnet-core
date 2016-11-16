namespace Nofdev.Core.Domain
{
    /// <summary>
    /// ���⻧�ӿ�
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITenant<T>
    {
        T TenantId { get; set; }
    }

    /// <summary>
    /// Ĭ�ϵĶ��⻧�ӿڣ�IDΪint)
    /// </summary>
    public interface ITenant : ITenant<int>
    {

    }

    /// <summary>
    /// �⻧�����Ľӿ�
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ITenantContext<out T>
    {
        T TenantId { get; }
    }

    /// <summary>
    /// Ĭ�ϵ��⻧�����Ľӿڣ�IDΪint)
    /// </summary>
    public interface ITenantContext : ITenantContext<int>
    {

    }
}