﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_Jogo
{
    public enum eCategorias
    {
        [Description("Ação")]
        Acao,

        [Description("RPG")]
        RPG,

        [Description("Tiro")]
        Tiro,

        [Description("Construção")]
        Construcao,
    }

    public static class EnumExtender
    {
        public static string GetDescription(this Enum enumerationValue)
        {
            Type type = enumerationValue.GetType();
            MemberInfo member = type.GetMembers().Where(w => w.Name == Enum.GetName(type, enumerationValue)).FirstOrDefault();
            var attribute = member?.GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() as DescriptionAttribute;
            return attribute?.Description != null ? attribute.Description : enumerationValue.ToString();
        }

        public static T GetEnumValue<T>(this string description)
        {
            var type = typeof(T);
            if (!type.GetTypeInfo().IsEnum)
                throw new ArgumentException();

            var field = type.GetFields().SelectMany(f => f.GetCustomAttributes(typeof(DescriptionAttribute), false), (f, a) => new { Field = f, Att = a })
                                        .Where(a => ((DescriptionAttribute)a.Att).Description == description).SingleOrDefault();
            return field == null ? default(T) : (T)field.Field.GetRawConstantValue();
        }
    }
}
