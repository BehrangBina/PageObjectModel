# PageObjectModel

Variation of Page Object Model Framework

# Principle:

Using Step definition files seprately and differently
1. Does not create lots of step definition files (Share Steps)
2. Does not instantiate page classes in step definition Class
3. Avoids putting any functionality in the step definition Class

|Steps              |Functionality|
|:----              |:------------|
|BaseScenariosSteps|For steps that point to methods that can be used in any BDD testing project|
|BaseSteps|Is a place holder that inherits the Page class. This is to follow the POM concepts|
|DynamicTableSteps|For steps that point to methods with dynamic tables.|
|NonDynamicTableSteps|For steps that point to methods with non-dynamic tables|
|ReturnClickSteps|For steps that point to methods that return another class page|
|SendKeysSteps|For steps that point to methods with send keys functionality|
|ValidationSteps|For steps that point to methods with validation functionality|
|VoidClickSteps|For steps that point to methods with void links, that are links that don't return a new page.|

