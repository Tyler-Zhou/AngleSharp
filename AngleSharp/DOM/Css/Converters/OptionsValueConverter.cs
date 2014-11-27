﻿namespace AngleSharp.DOM.Css
{
    using System;

    sealed class OptionsValueConverter<T1, T2> : IValueConverter<Tuple<T1, T2>>
    {
        readonly IValueConverter<T1> _first;
        readonly IValueConverter<T2> _second;
        readonly Tuple<T1, T2> _defaults;

        public OptionsValueConverter(IValueConverter<T1> first, IValueConverter<T2> second, Tuple<T1, T2> defaults)
        {
            _first = first;
            _second = second;
            _defaults = defaults;
        }

        public Boolean TryConvert(CSSValue value, Action<Tuple<T1, T2>> setResult)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 2)
                return false;

            var t1 = TryAll(items, _first, _defaults.Item1);
            var t2 = TryAll(items, _second, _defaults.Item2);

            if (items.Length > 0)
                return false;

            setResult(Tuple.Create(t1, t2));
            return true;
        }

        static T TryAll<T>(CSSValueList list, IValueConverter<T> converter, T defaultValue)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (converter.TryConvert(list[i], tmp => defaultValue = tmp))
                {
                    list.Remove(list[i]);
                    break;
                }
            }

            return defaultValue;
        }

        public Boolean Validate(CSSValue value)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 2)
                return false;

            var validators = new IValueConverter[] { _first, _second };

            for (int i = 0; i < validators.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (validators[i].Validate(items[j]))
                    {
                        items.Remove(items[j]);
                        break;
                    }
                }
            }

            return items.Length == 0;
        }
    }

    sealed class OptionsValueConverter<T1, T2, T3> : IValueConverter<Tuple<T1, T2, T3>>
    {
        readonly IValueConverter<T1> _first;
        readonly IValueConverter<T2> _second;
        readonly IValueConverter<T3> _third;
        readonly Tuple<T1, T2, T3> _defaults;

        public OptionsValueConverter(IValueConverter<T1> first, IValueConverter<T2> second, IValueConverter<T3> third, Tuple<T1, T2, T3> defaults)
        {
            _first = first;
            _second = second;
            _third = third;
            _defaults = defaults;
        }

        public Boolean TryConvert(CSSValue value, Action<Tuple<T1, T2, T3>> setResult)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 3)
                return false;

            var t1 = TryAll(items, _first, _defaults.Item1);
            var t2 = TryAll(items, _second, _defaults.Item2);
            var t3 = TryAll(items, _third, _defaults.Item3);

            if (items.Length > 0)
                return false;

            setResult(Tuple.Create(t1, t2, t3));
            return true;
        }

        static T TryAll<T>(CSSValueList list, IValueConverter<T> converter, T defaultValue)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (converter.TryConvert(list[i], tmp => defaultValue = tmp))
                {
                    list.Remove(list[i]);
                    break;
                }
            }

            return defaultValue;
        }

        public Boolean Validate(CSSValue value)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 3)
                return false;

            var validators = new IValueConverter[] { _first, _second, _third };

            for (int i = 0; i < validators.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (validators[i].Validate(items[j]))
                    {
                        items.Remove(items[j]);
                        break;
                    }
                }
            }

            return items.Length == 0;
        }
    }

    sealed class OptionsValueConverter<T1, T2, T3, T4> : IValueConverter<Tuple<T1, T2, T3, T4>>
    {
        readonly IValueConverter<T1> _first;
        readonly IValueConverter<T2> _second;
        readonly IValueConverter<T3> _third;
        readonly IValueConverter<T4> _fourth;
        readonly Tuple<T1, T2, T3, T4> _defaults;

        public OptionsValueConverter(IValueConverter<T1> first, IValueConverter<T2> second, IValueConverter<T3> third, IValueConverter<T4> fourth, Tuple<T1, T2, T3, T4> defaults)
        {
            _first = first;
            _second = second;
            _third = third;
            _fourth = fourth;
            _defaults = defaults;
        }

        public Boolean TryConvert(CSSValue value, Action<Tuple<T1, T2, T3, T4>> setResult)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 4)
                return false;

            var t1 = TryAll(items, _first, _defaults.Item1);
            var t2 = TryAll(items, _second, _defaults.Item2);
            var t3 = TryAll(items, _third, _defaults.Item3);
            var t4 = TryAll(items, _fourth, _defaults.Item4);

            if (items.Length > 0)
                return false;

            setResult(Tuple.Create(t1, t2, t3, t4));
            return true;
        }

        static T TryAll<T>(CSSValueList list, IValueConverter<T> converter, T defaultValue)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (converter.TryConvert(list[i], tmp => defaultValue = tmp))
                {
                    list.Remove(list[i]);
                    break;
                }
            }

            return defaultValue;
        }

        public Boolean Validate(CSSValue value)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 4)
                return false;

            var validators = new IValueConverter[] { _first, _second, _third, _fourth };

            for (int i = 0; i < validators.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (validators[i].Validate(items[j]))
                    {
                        items.Remove(items[j]);
                        break;
                    }
                }
            }

            return items.Length == 0;
        }
    }

    sealed class OptionsValueConverter<T1, T2, T3, T4, T5, T6, T7, T8> : IValueConverter<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>>
    {
        readonly IValueConverter<T1> _first;
        readonly IValueConverter<T2> _second;
        readonly IValueConverter<T3> _third;
        readonly IValueConverter<T4> _fourth;
        readonly IValueConverter<T5> _fifth;
        readonly IValueConverter<T6> _sixth;
        readonly IValueConverter<T7> _seventh;
        readonly IValueConverter<T8> _eigth;
        readonly Tuple<T1, T2, T3, T4, T5, T6, T7, T8> _defaults;

        public OptionsValueConverter(IValueConverter<T1> first, IValueConverter<T2> second, IValueConverter<T3> third, IValueConverter<T4> fourth, IValueConverter<T5> fifth, IValueConverter<T6> sixth, IValueConverter<T7> seventh, IValueConverter<T8> eighth, Tuple<T1, T2, T3, T4, T5, T6, T7, T8> defaults)
        {
            _first = first;
            _second = second;
            _third = third;
            _fourth = fourth;
            _fifth = fifth;
            _sixth = sixth;
            _seventh = seventh;
            _eigth = eighth;
            _defaults = defaults;
        }

        public Boolean TryConvert(CSSValue value, Action<Tuple<T1, T2, T3, T4, T5, T6, T7, T8>> setResult)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 8)
                return false;

            var t1 = TryAll(items, _first, _defaults.Item1);
            var t2 = TryAll(items, _second, _defaults.Item2);
            var t3 = TryAll(items, _third, _defaults.Item3);
            var t4 = TryAll(items, _fourth, _defaults.Item4);
            var t5 = TryAll(items, _fifth, _defaults.Item5);
            var t6 = TryAll(items, _sixth, _defaults.Item6);
            var t7 = TryAll(items, _seventh, _defaults.Item7);
            var t8 = TryAll(items, _eigth, _defaults.Rest);

            if (items.Length > 0)
                return false;

            setResult(new Tuple<T1, T2, T3, T4, T5, T6, T7, T8>(t1, t2, t3, t4, t5, t6, t7, t8));
            return true;
        }

        static T TryAll<T>(CSSValueList list, IValueConverter<T> converter, T defaultValue)
        {
            for (int i = 0; i < list.Length; i++)
            {
                if (converter.TryConvert(list[i], tmp => defaultValue = tmp))
                {
                    list.Remove(list[i]);
                    break;
                }
            }

            return defaultValue;
        }

        public Boolean Validate(CSSValue value)
        {
            var items = value as CSSValueList ?? new CSSValueList(value);

            if (items.Length > 8)
                return false;

            var validators = new IValueConverter[] { _first, _second, _third, _fourth, _fifth, _sixth, _seventh, _eigth };

            for (int i = 0; i < validators.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if (validators[i].Validate(items[j]))
                    {
                        items.Remove(items[j]);
                        break;
                    }
                }
            }

            return items.Length == 0;
        }
    }
}
