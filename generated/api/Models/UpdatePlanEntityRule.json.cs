// Code generated by Microsoft (R) AutoRest Code Generator (autorest: 3.0.6365, generator: {generator})
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Commvault.Powershell.Models
{
    using static Commvault.Powershell.Runtime.Extensions;

    /// <summary>
    /// Plan entity rule update object. Fields in this object need to be populated to suggest what need to be changed in the rule.
    /// User can provide all rule options or can specify a specific rule group. Be default, for rule to be applicable for association
    /// to a workload, ALL specified rules in that Rule need to be matched.
    /// </summary>
    public partial class UpdatePlanEntityRule
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
        /// Deserializes a <see cref="Commvault.Powershell.Runtime.Json.JsonNode"/> into an instance of Commvault.Powershell.Models.IUpdatePlanEntityRule.
        /// </summary>
        /// <param name="node">a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" /> to deserialize from.</param>
        /// <returns>an instance of Commvault.Powershell.Models.IUpdatePlanEntityRule.</returns>
        public static Commvault.Powershell.Models.IUpdatePlanEntityRule FromJson(Commvault.Powershell.Runtime.Json.JsonNode node)
        {
            return node is Commvault.Powershell.Runtime.Json.JsonObject json ? new UpdatePlanEntityRule(json) : null;
        }

        /// <summary>
        /// Serializes this instance of <see cref="UpdatePlanEntityRule" /> into a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
        /// </summary>
        /// <param name="container">The <see cref="Commvault.Powershell.Runtime.Json.JsonObject"/> container to serialize this object into. If the caller
        /// passes in <c>null</c>, a new instance will be created and returned to the caller.</param>
        /// <param name="serializationMode">Allows the caller to choose the depth of the serialization. See <see cref="Commvault.Powershell.Runtime.SerializationMode"/>.</param>
        /// <returns>
        /// a serialized instance of <see cref="UpdatePlanEntityRule" /> as a <see cref="Commvault.Powershell.Runtime.Json.JsonNode" />.
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
            AddIf( null != this._rule ? (Commvault.Powershell.Runtime.Json.JsonNode) this._rule.ToJson(null,serializationMode) : null, "rule" ,container.Add );
            AddIf( null != this._plan ? (Commvault.Powershell.Runtime.Json.JsonNode) this._plan.ToJson(null,serializationMode) : null, "plan" ,container.Add );
            if (null != this._workloads)
            {
                var __w = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __x in this._workloads )
                {
                    AddIf(__x?.ToJson(null, serializationMode) ,__w.Add);
                }
                container.Add("workloads",__w);
            }
            if (null != this._serverGroups)
            {
                var __r = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __s in this._serverGroups )
                {
                    AddIf(__s?.ToJson(null, serializationMode) ,__r.Add);
                }
                container.Add("serverGroups",__r);
            }
            if (null != this._regions)
            {
                var __m = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __n in this._regions )
                {
                    AddIf(__n?.ToJson(null, serializationMode) ,__m.Add);
                }
                container.Add("regions",__m);
            }
            AddIf( null != this._rank ? (Commvault.Powershell.Runtime.Json.JsonNode)new Commvault.Powershell.Runtime.Json.JsonNumber((int)this._rank) : null, "rank" ,container.Add );
            if (null != this._solutions)
            {
                var __h = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __i in this._solutions )
                {
                    AddIf(__i?.ToJson(null, serializationMode) ,__h.Add);
                }
                container.Add("solutions",__h);
            }
            if (null != this._tags)
            {
                var __c = new Commvault.Powershell.Runtime.Json.XNodeArray();
                foreach( var __d in this._tags )
                {
                    AddIf(__d?.ToJson(null, serializationMode) ,__c.Add);
                }
                container.Add("tags",__c);
            }
            AfterToJson(ref container);
            return container;
        }

        /// <summary>
        /// Deserializes a Commvault.Powershell.Runtime.Json.JsonObject into a new instance of <see cref="UpdatePlanEntityRule" />.
        /// </summary>
        /// <param name="json">A Commvault.Powershell.Runtime.Json.JsonObject instance to deserialize from.</param>
        internal UpdatePlanEntityRule(Commvault.Powershell.Runtime.Json.JsonObject json)
        {
            bool returnNow = false;
            BeforeFromJson(json, ref returnNow);
            if (returnNow)
            {
                return;
            }
            {_rule = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("rule"), out var __jsonRule) ? Commvault.Powershell.Models.IdName.FromJson(__jsonRule) : Rule;}
            {_plan = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonObject>("plan"), out var __jsonPlan) ? Commvault.Powershell.Models.IdName.FromJson(__jsonPlan) : Plan;}
            {_workloads = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("workloads"), out var __jsonWorkloads) ? If( __jsonWorkloads as Commvault.Powershell.Runtime.Json.JsonArray, out var __v) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__v, (__u)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__u) )) ))() : null : Workloads;}
            {_serverGroups = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("serverGroups"), out var __jsonServerGroups) ? If( __jsonServerGroups as Commvault.Powershell.Runtime.Json.JsonArray, out var __q) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__q, (__p)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__p) )) ))() : null : ServerGroups;}
            {_regions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("regions"), out var __jsonRegions) ? If( __jsonRegions as Commvault.Powershell.Runtime.Json.JsonArray, out var __l) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__l, (__k)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__k) )) ))() : null : Regions;}
            {_rank = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonNumber>("rank"), out var __jsonRank) ? (int?)__jsonRank : Rank;}
            {_solutions = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("solutions"), out var __jsonSolutions) ? If( __jsonSolutions as Commvault.Powershell.Runtime.Json.JsonArray, out var __g) ? new global::System.Func<Commvault.Powershell.Models.IIdName[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__g, (__f)=>(Commvault.Powershell.Models.IIdName) (Commvault.Powershell.Models.IdName.FromJson(__f) )) ))() : null : Solutions;}
            {_tags = If( json?.PropertyT<Commvault.Powershell.Runtime.Json.JsonArray>("tags"), out var __jsonTags) ? If( __jsonTags as Commvault.Powershell.Runtime.Json.JsonArray, out var __b) ? new global::System.Func<Commvault.Powershell.Models.IPlanEntityRuleTag[]>(()=> global::System.Linq.Enumerable.ToArray(global::System.Linq.Enumerable.Select(__b, (__a)=>(Commvault.Powershell.Models.IPlanEntityRuleTag) (Commvault.Powershell.Models.PlanEntityRuleTag.FromJson(__a) )) ))() : null : Tags;}
            AfterFromJson(json);
        }
    }
}