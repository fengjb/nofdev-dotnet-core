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

}