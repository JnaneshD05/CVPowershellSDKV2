// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.8.3, generator: @autorest/powershell@3.0.415)
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// If updating pattern, the value which needs to be retained also needs to be provided along with the updated value
    /// </summary>
    public partial class PlanPattern
    {

        /// <summary>
        /// <c>AfterFromJson</c> will be called after the json deserialization has finished, allowing customization of the object
        /// before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>

        partial void AfterFromJson(Commvault.Powershell.Runtime.Json.JsonObject json);

        /// <summary>
        /// <c>AfterToJson</c> will be called after the json erialization has finished, allowing customization of the <see cref="Commvault.Powershell.Runtime.Json.JsonObject"
        /// /> before it is returned. Implement this method in a partial class to enable this behavior
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>

        partial void AfterToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container);

        /// <summary>
        /// <c>BeforeFromJson</c> will be called before the json deserialization has commenced, allowing complete customization of
        /// the object before it is deserialized.
        /// If you wish to disable the default deserialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="json">The JsonNode that should be deserialized into this object.</param>
        /// <param name="returnNow">Determines if the rest of the deserialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeFromJson(Commvault.Powershell.Runtime.Json.JsonObject json, ref bool returnNow);

        /// <summary>
        /// <c>BeforeToJson</c> will be called before the json serialization has commenced, allowing complete customization of the
        /// object before it is serialized.
        /// If you wish to disable the default serialization entirely, return <c>true</c> in the <see "returnNow" /> output parameter.
        /// Implement this method in a partial class to enable this behavior.
        /// </summary>
        /// <param name="container">The JSON container that the serialization result will be placed in.</param>
        /// <param name="returnNow">Determines if the rest of the serialization should be processed, or if the method should return
        /// instantly.</param>

        partial void BeforeToJson(ref Commvault.Powershell.Runtime.Json.JsonObject container, ref bool returnNow);

        /// <summary>
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IPlanPattern.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IPlanPattern.</returns>
        public static Commvault.Powershell.Models.IPlanPattern FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new PlanPattern(json) : null;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="PlanPattern" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal PlanPattern(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_minuteFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("minuteFrequency"), out var __jsonMinuteFrequency) ? (int?)__jsonMinuteFrequency : MinuteFrequency;}
            {_hourlyFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("hourlyFrequency"), out var __jsonHourlyFrequency) ? (int?)__jsonHourlyFrequency : HourlyFrequency;}
            {_dailyFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("dailyFrequency"), out var __jsonDailyFrequency) ? (int?)__jsonDailyFrequency : DailyFrequency;}
            {_weeklyFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("weeklyFrequency"), out var __jsonWeeklyFrequency) ? (int?)__jsonWeeklyFrequency : WeeklyFrequency;}
            {_weeklyFrequencyDays = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("weeklyFrequencyDays"), out var __jsonWeeklyFrequencyDays) ? If( __jsonWeeklyFrequencyDays as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<string[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(string) (__u is Commvault.Powershell.Runtime.Json.JsonString __t ? (string)(__t.ToString()) : null)) ))() : null : WeeklyFrequencyDays;}
            {_monthlyFrequency = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("monthlyFrequency"), out var __jsonMonthlyFrequency) ? (int?)__jsonMonthlyFrequency : MonthlyFrequency;}
            {_monthlyFrequencyWeekOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("monthlyFrequencyWeekOfMonth"), out var __jsonMonthlyFrequencyWeekOfMonth) ? (string)__jsonMonthlyFrequencyWeekOfMonth : (string)MonthlyFrequencyWeekOfMonth;}
            {_monthlyFrequencyDayOfWeek = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("monthlyFrequencyDayOfWeek"), out var __jsonMonthlyFrequencyDayOfWeek) ? (string)__jsonMonthlyFrequencyDayOfWeek : (string)MonthlyFrequencyDayOfWeek;}
            {_monthlyFrequencyDayOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("monthlyFrequencyDayOfMonth"), out var __jsonMonthlyFrequencyDayOfMonth) ? (int?)__jsonMonthlyFrequencyDayOfMonth : MonthlyFrequencyDayOfMonth;}
            {_yearlyFrequencyWeekOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("yearlyFrequencyWeekOfMonth"), out var __jsonYearlyFrequencyWeekOfMonth) ? (string)__jsonYearlyFrequencyWeekOfMonth : (string)YearlyFrequencyWeekOfMonth;}
            {_yearlyFrequencyDayOfWeek = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("yearlyFrequencyDayOfWeek"), out var __jsonYearlyFrequencyDayOfWeek) ? (string)__jsonYearlyFrequencyDayOfWeek : (string)YearlyFrequencyDayOfWeek;}
            {_yearlyFrequencyDayOfMonth = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("yearlyFrequencyDayOfMonth"), out var __jsonYearlyFrequencyDayOfMonth) ? (int?)__jsonYearlyFrequencyDayOfMonth : YearlyFrequencyDayOfMonth;}
            {_yearlyFrequencyMonthOfYear = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonString>("yearlyFrequencyMonthOfYear"), out var __jsonYearlyFrequencyMonthOfYear) ? (string)__jsonYearlyFrequencyMonthOfYear : (string)YearlyFrequencyMonthOfYear;}
            {_startTime = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("startTime"), out var __jsonStartTime) ? (int?)__jsonStartTime : StartTime;}
            AfterFromJson(json);
        }

        /// <summary>
        /// Serializes this instance of <see cref="PlanPattern" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="PlanPattern" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </returns>
        public Commvault.Powershell.Runtime.Json.JsonNode ToJson(Commvault.Powershell.Runtime.Json.JsonObject container, Commvault.Powershell.Runtime.SerializationMode serializationMode)
        {
            container = container ?? new Commvault.Powershell.Runtime.Json.JsonObject();

            bool returnNow = false;
            BeforeToJson(ref container, ref returnNow);
            if (returnNow)
            {
                return container;
            }
            AddIf( null != this._minuteFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._minuteFrequency) : null, "minuteFrequency" ,container.Add );
            AddIf( null != this._hourlyFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._hourlyFrequency) : null, "hourlyFrequency" ,container.Add );
            AddIf( null != this._dailyFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._dailyFrequency) : null, "dailyFrequency" ,container.Add );
            AddIf( null != this._weeklyFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._weeklyFrequency) : null, "weeklyFrequency" ,container.Add );
            if (null != this._weeklyFrequencyDays)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._weeklyFrequencyDays )
                {
                    AddIf(null != (((object)__x)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(__x.ToString()) : null ,__w.Add);
                }
                container.Add("weeklyFrequencyDays",__w);
            }
            AddIf( null != this._monthlyFrequency ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._monthlyFrequency) : null, "monthlyFrequency" ,container.Add );
            AddIf( null != (((object)this._monthlyFrequencyWeekOfMonth)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._monthlyFrequencyWeekOfMonth.ToString()) : null, "monthlyFrequencyWeekOfMonth" ,container.Add );
            AddIf( null != (((object)this._monthlyFrequencyDayOfWeek)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._monthlyFrequencyDayOfWeek.ToString()) : null, "monthlyFrequencyDayOfWeek" ,container.Add );
            AddIf( null != this._monthlyFrequencyDayOfMonth ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._monthlyFrequencyDayOfMonth) : null, "monthlyFrequencyDayOfMonth" ,container.Add );
            AddIf( null != (((object)this._yearlyFrequencyWeekOfMonth)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._yearlyFrequencyWeekOfMonth.ToString()) : null, "yearlyFrequencyWeekOfMonth" ,container.Add );
            AddIf( null != (((object)this._yearlyFrequencyDayOfWeek)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._yearlyFrequencyDayOfWeek.ToString()) : null, "yearlyFrequencyDayOfWeek" ,container.Add );
            AddIf( null != this._yearlyFrequencyDayOfMonth ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._yearlyFrequencyDayOfMonth) : null, "yearlyFrequencyDayOfMonth" ,container.Add );
            AddIf( null != (((object)this._yearlyFrequencyMonthOfYear)?.ToString()) ? (Commvault.Powershell.Runtime.Json.JsonNode) new Commvault.Powershell.Runtime.Json.JsonString(this._yearlyFrequencyMonthOfYear.ToString()) : null, "yearlyFrequencyMonthOfYear" ,container.Add );
            AddIf( null != this._startTime ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._startTime) : null, "startTime" ,container.Add );
            AfterToJson(ref container);
            return container;
        }
    }
}