<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128624088/21.1.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3175)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
## In v21.1 and newer this functionality isn't supported

In previous versions, there was a drawing issue in our components - column components like the filter button were painted in the incorrect place - in the middle right position.
Older versions of this example relied on this bug. In v21.1, we fixed this painting issue and the column components are now painted in the correct position - in the top right corner.
But the Grid still implies that these components are painted as they used to. This leads to a visual inconsistency and inability to click on these column components.
Now, Banded Grid's internal architecture doesn't allow implementing this functionality.
