﻿namespace SKIT.FlurlHttpClient.Wechat.Api.Models
{
    /// <summary>
    /// <para>表示 [POST] /shop/ecaftersale/cancel 接口的请求。</para>
    /// </summary>
    public class ShopECAftersaleCancelRequest : WechatApiRequest, IInferable<ShopECAftersaleCancelRequest, ShopECAftersaleCancelResponse>
    {
        /// <summary>
        /// 获取或设置售后单号。与字段 <see cref="OutAftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("aftersale_id")]
        public long? AftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置商家自定义售后单号。与字段 <see cref="AftersaleOrderId"/> 二选一。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("out_aftersale_id")]
        [System.Text.Json.Serialization.JsonPropertyName("out_aftersale_id")]
        public string? OutAftersaleOrderId { get; set; }

        /// <summary>
        /// 获取或设置用户的 OpenId。
        /// </summary>
        [Newtonsoft.Json.JsonProperty("openid")]
        [System.Text.Json.Serialization.JsonPropertyName("openid")]
        public string OpenId { get; set; } = string.Empty;
    }
}
