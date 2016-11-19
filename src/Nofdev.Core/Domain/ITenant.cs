namespace Nofdev.Core.Domain
{
    /// <summary>
    /// ���⻧�ӿ�
    /// </summary>
    /// <typeparam name="TTenantKey"></typeparam>
    public interface ITenant<TTenantKey>
    {
        TTenantKey TenantId { get; set; }
    }

    /// <summary>
    /// Ĭ�ϵĶ��⻧�ӿ�
    /// </summary>
    public interface ITenant : ITenant<string>
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
    public interface ITenantContext : ITenantContext<string>
    {

    }
}