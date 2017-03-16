# Restaurant

## Menu Class

### Properties

| Member      | Data Type        | get    | set     | Static | Readonly |
| ----------- | ---------------- | ------ | ------- | ------ | -------- |
| Items       | `MenuItem[]`     | public | private | N      | Y        |
| LastUpdated | `DateTime`       | public | private | N      | N        |

### Fields

| Member      | Data Type        | Access Level | Static | Readonly |
| ----------- | ---------------- | ------------ | ------ | -------- |
| items       | `List<MenuItem>` | private      | N      | Y        |
| lastUpdated | `DateTime`       | private      | N      | N        |

### Methods

| Member  | Return Type | Access Level | Arguments       | Static |
| ------- | ----------- | ------------ | --------------- | ------ |
| AddItem | void        | public       | `MenuItem item` | N      |


## Menu Item Class

### Properties

| Member      | Data Type | get    | set     | Static | Readonly |
| ----------- | --------- | ------ | ------- | ------ | -------- |
| Price       | `decimal` | public | private | N      | N        |
| Description | `string`  | public | private | N      | N        |
| Category    | `string`  | public | private | N      | N        |
| IsNew       | `bool`    | public | private | N      | N        |

### Fields

| Member      | Data Type  | Access Level | Static | Readonly |
| ----------- | ---------- | ------------ | ------ | -------- |
| price       | `decimal`  | private      | N      | N        |
| description | `string`   | private      | N      | N        |
| category    | `string`   | private      | N      | N        |
| isNew       | `bool`     | private      | N      | N        |
| categories  | `string[]` | private      | Y      | Y        |