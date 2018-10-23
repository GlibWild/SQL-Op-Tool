using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DBOperationTool.Entities
{
    public class FieldProperties
    {
        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName { get; set; }
        /// <summary>
        /// 字段类型
        /// </summary>
        public string FieldType { get; set; }
        /// <summary>
        /// 字段值是否允许为空
        /// </summary>
        public int FieldValueNull { get; set; }
        /// <summary>
        /// 是否为主键
        /// </summary>
        public int IsPrimaryKey { get; set; }
        /// <summary>
        /// 是否为自增长
        /// </summary>
        public int SelfPropagation { get; set; }
        /// <summary>
        /// 字段长度
        /// </summary>
        public int FieldLength { get; set; }
        /// <summary>
        /// 信息，部分情况下会获取到错误信息
        /// </summary>
        public string Tag { get; set; }

        /// <summary>
        /// 比较两个ServerEntity是否相等
        /// </summary>
        /// <param name="se"></param>
        /// <param name="serverEntity"></param>
        /// <returns></returns>
        public static bool ComparePropertiesIsEqual(ServerEntity se, ServerEntity serverEntity)
        {
            bool flag = true;
            flag &= (se.Field[0].FieldName == serverEntity.Field[0].FieldName);
            flag &= (se.Field[0].FieldType == serverEntity.Field[0].FieldType);
            flag &= (se.Field[0].FieldValueNull == serverEntity.Field[0].FieldValueNull);
            flag &= (se.Field[0].IsPrimaryKey == serverEntity.Field[0].IsPrimaryKey);
            flag &= (se.Field[0].FieldLength == serverEntity.Field[0].FieldLength);
            flag &= (se.Field[0].SelfPropagation == serverEntity.Field[0].SelfPropagation);
            return flag;
        }
    }
}
