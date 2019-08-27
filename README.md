# WorkflowDesignPattern
The design pattern used in this repository can be used to process any workflow or flowchart.
If anybody has a flowchart and the person wants to create a rule engine to process the workflow steps as defined in a flowchart, then this design pattern can come handy.
Its developed using .Net Core and hence qualifies as FOSS(Free and Open Source Software)
Primary actors in thsi design pattern are 2 interfaces -IDecision and ICondition.
IDecision has two branches OnYes and OnNo which are also IDecision entities. This comes handy when the enxt step of a decision is also another decision.
If the next step is not a decision, we can leave the ICondition property as blank. When the decison is evaluated, it will see the condition as null and not process any further. In such situations, we can always create a dummy Yes class which will not have any condition to execute and will just process the evalaution steps
