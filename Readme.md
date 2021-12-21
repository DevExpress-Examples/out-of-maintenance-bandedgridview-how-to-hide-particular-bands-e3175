## In v21.1 and newer this functionality isn't supported

In previous versions, there was a drawing issue in our components - column components like the filter button were painted in the incorrect place - in the middle right position.
Older versions of this example relied on this bug. In v21.1, we fixed this painting issue and the column components are now painted in the correct position - in the top right corner.
But the Grid still implies that these components are painted as they used to. This leads to a visual inconsistency and inability to click on these column components.
Now, Banded Grid's internal architecture doesn't allow implementing this functionality.
