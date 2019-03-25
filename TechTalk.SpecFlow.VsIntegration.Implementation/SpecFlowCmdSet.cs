﻿namespace TechTalk.SpecFlow.VsIntegration
{
    public enum SpecFlowCmdSet : uint 
    {
        GenerateStepDefinitionSkeleton = PkgCmdIDList.cmdidGenerateStepDefinitionSkeleton,
        RunScenarios = PkgCmdIDList.cmdidRunScenarios,
        DebugScenarios = PkgCmdIDList.cmdidDebugScenarios,
        GoToStepDefinition = PkgCmdIDList.cmdidGoToStepDefinition,
        ReGenerateAll = PkgCmdIDList.cmdidReGenerateAll,
        GoToSteps = PkgCmdIDList.cmdidGoToSteps,
        ContextDependentNavigation = PkgCmdIDList.cmdidContextDependentNavigation,
    }
}