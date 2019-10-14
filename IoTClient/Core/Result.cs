﻿using System.Collections.Generic;

namespace IoTClient.Core
{
    /// <summary>
    /// 请求结果
    /// </summary>
    public class Result<T>
    {
        public Result()
        {
        }

        public Result(T data)
        {
            Value = data;
        }
        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSucceed { get; set; } = true;

        /// <summary>
        /// 异常消息
        /// </summary>
        public string Err { get; set; }

        /// <summary>
        /// 异常集合
        /// </summary>
        public List<string> ErrList { get; set; } = new List<string>();

        /// <summary>
        /// 数据结果
        /// </summary>
        public T Value { get; set; }
    }

    public class Result
    {
        public Result()
        {
        }

        /// <summary>
        /// 是否成功
        /// </summary>
        public bool IsSucceed { get; set; } = true;

        /// <summary>
        /// 异常消息
        /// </summary>
        public string Err { get; set; }

        /// <summary>
        /// 异常集合
        /// </summary>
        public List<string> ErrList { get; set; } = new List<string>();
    }
}
