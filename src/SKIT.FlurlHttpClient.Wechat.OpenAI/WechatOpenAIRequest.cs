﻿using System;

namespace SKIT.FlurlHttpClient.Wechat.OpenAI
{
    /// <summary>
    /// 表示微信智能对话 API 请求的基类。
    /// </summary>
    public abstract class WechatOpenAIRequest : IWechatRequest
    {
        /// <summary>
        /// 获取或设置请求超时时间（单位：毫秒）。如果不指定将使用构造 <see cref="WechatOpenAIClient"/> 时的 <see cref="WechatOpenAIClientOptions.Timeout"/> 参数，这在需要指定特定耗时请求（比如上传或下载文件）的超时时间时很有用。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlIgnore]
        [System.Xml.Serialization.SoapIgnore]
        public virtual int? Timeout { get; set; }

        /// <summary>
        /// 获取或设置请求唯一标识。如果不指定将有系统自动生成。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlIgnore]
        [System.Xml.Serialization.SoapIgnore]
        public virtual string? RequestId { get; set; }

        /// <summary>
        /// 获取或设置 Bot ID。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlIgnore]
        [System.Xml.Serialization.SoapIgnore]
        public virtual string? BotId { get; set; }

        /// <summary>
        /// 获取或设置接口访问令牌。
        /// </summary>
        [Newtonsoft.Json.JsonIgnore]
        [System.Text.Json.Serialization.JsonIgnore]
        [System.Xml.Serialization.XmlIgnore]
        [System.Xml.Serialization.SoapIgnore]
        public virtual string? AccessToken { get; set; }
    }

    public abstract class WechatOpenAIRequestEncryptedXmlable : WechatOpenAIRequest
    {
        /// <summary>
        /// 获取或设置微信 AppId。如果不指定将使用构造 <see cref="WechatOpenAIClient"/> 时的 <see cref="WechatOpenAIClientOptions.AppId"/> 参数。
        /// </summary>
        [System.Xml.Serialization.XmlElement("appid")]
        public string? AppId { get; set; }
    }
}
