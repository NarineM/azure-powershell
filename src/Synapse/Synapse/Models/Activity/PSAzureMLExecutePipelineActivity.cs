// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Azure ML Execute Pipeline activity.
    /// </summary>
    [Newtonsoft.Json.JsonObject("AzureMLExecutePipeline")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSAzureMLExecutePipelineActivity : PSExecutionActivity
    {
        /// <summary>
        /// Initializes a new instance of the PSAzureMLExecutePipelineActivity
        /// class.
        /// </summary>
        public PSAzureMLExecutePipelineActivity()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets ID of the published Azure ML pipeline. Type: string
        /// (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlPipelineId")]
        public object MlPipelineId { get; set; }

        /// <summary>
        /// Gets or sets run history experiment name of the pipeline run. This
        /// information will be passed in the ExperimentName property of the
        /// published pipeline execution request. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.experimentName")]
        public object ExperimentName { get; set; }

        /// <summary>
        /// Gets or sets key,Value pairs to be passed to the published Azure ML
        /// pipeline endpoint. Keys must match the names of pipeline parameters
        /// defined in the published pipeline. Values will be passed in the
        /// ParameterAssignments property of the published pipeline execution
        /// request. Type: object with key value pairs (or Expression with
        /// resultType object).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlPipelineParameters")]
        public object MlPipelineParameters { get; set; }

        /// <summary>
        /// Gets or sets the parent Azure ML Service pipeline run id. This
        /// information will be passed in the ParentRunId property of the
        /// published pipeline execution request. Type: string (or Expression
        /// with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.mlParentRunId")]
        public object MlParentRunId { get; set; }

        /// <summary>
        /// Gets or sets whether to continue execution of other steps in the
        /// PipelineRun if a step fails. This information will be passed in the
        /// continueOnStepFailure property of the published pipeline execution
        /// request. Type: boolean (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.continueOnStepFailure")]
        public object ContinueOnStepFailure { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (MlPipelineId == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "MlPipelineId");
            }
        }

        public override Activity ToSdkObject()
        {
            var activity = new AzureMLExecutePipelineActivity(this.Name, this.MlPipelineId);
            activity.ExperimentName = this.ExperimentName;
            activity.MlPipelineParameters = this.MlPipelineParameters;
            activity.MlParentRunId = this.MlParentRunId;
            activity.ContinueOnStepFailure = this.ContinueOnStepFailure;
            activity.LinkedServiceName = this.LinkedServiceName;
            activity.Policy = this.Policy;
            SetProperties(activity);
            return activity;
        }
    }
}

