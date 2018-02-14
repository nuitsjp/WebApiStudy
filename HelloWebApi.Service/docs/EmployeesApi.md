# HelloWebApi.Service.Api.EmployeesApi

All URIs are relative to *http://localhost:9000*

Method | HTTP request | Description
------------- | ------------- | -------------
[**EmployeesDelete**](EmployeesApi.md#employeesdelete) | **DELETE** /api/Employees/{id} | 
[**EmployeesGet**](EmployeesApi.md#employeesget) | **GET** /api/Employees | 
[**EmployeesGet_0**](EmployeesApi.md#employeesget_0) | **GET** /api/Employees/{id} | 
[**EmployeesPost**](EmployeesApi.md#employeespost) | **POST** /api/Employees | 
[**EmployeesPut**](EmployeesApi.md#employeesput) | **PUT** /api/Employees/{id} | 


<a name="employeesdelete"></a>
# **EmployeesDelete**
> void EmployeesDelete (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using HelloWebApi.Service.Api;
using HelloWebApi.Service.Client;
using HelloWebApi.Service.Model;

namespace Example
{
    public class EmployeesDeleteExample
    {
        public void main()
        {
            var apiInstance = new EmployeesApi();
            var id = 56;  // int? | 

            try
            {
                apiInstance.EmployeesDelete(id);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesDelete: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesget"></a>
# **EmployeesGet**
> List<Employee> EmployeesGet ()



### Example
```csharp
using System;
using System.Diagnostics;
using HelloWebApi.Service.Api;
using HelloWebApi.Service.Client;
using HelloWebApi.Service.Model;

namespace Example
{
    public class EmployeesGetExample
    {
        public void main()
        {
            var apiInstance = new EmployeesApi();

            try
            {
                List&lt;Employee&gt; result = apiInstance.EmployeesGet();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesGet: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**List<Employee>**](Employee.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesget_0"></a>
# **EmployeesGet_0**
> string EmployeesGet_0 (int? id)



### Example
```csharp
using System;
using System.Diagnostics;
using HelloWebApi.Service.Api;
using HelloWebApi.Service.Client;
using HelloWebApi.Service.Model;

namespace Example
{
    public class EmployeesGet_0Example
    {
        public void main()
        {
            var apiInstance = new EmployeesApi();
            var id = 56;  // int? | 

            try
            {
                string result = apiInstance.EmployeesGet_0(id);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesGet_0: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 

### Return type

**string**

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json, text/json, application/xml, text/xml

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeespost"></a>
# **EmployeesPost**
> void EmployeesPost (string value)



### Example
```csharp
using System;
using System.Diagnostics;
using HelloWebApi.Service.Api;
using HelloWebApi.Service.Client;
using HelloWebApi.Service.Model;

namespace Example
{
    public class EmployeesPostExample
    {
        public void main()
        {
            var apiInstance = new EmployeesApi();
            var value = value_example;  // string | 

            try
            {
                apiInstance.EmployeesPost(value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesPost: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **value** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="employeesput"></a>
# **EmployeesPut**
> void EmployeesPut (int? id, string value)



### Example
```csharp
using System;
using System.Diagnostics;
using HelloWebApi.Service.Api;
using HelloWebApi.Service.Client;
using HelloWebApi.Service.Model;

namespace Example
{
    public class EmployeesPutExample
    {
        public void main()
        {
            var apiInstance = new EmployeesApi();
            var id = 56;  // int? | 
            var value = value_example;  // string | 

            try
            {
                apiInstance.EmployeesPut(id, value);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling EmployeesApi.EmployeesPut: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **id** | **int?**|  | 
 **value** | **string**|  | 

### Return type

void (empty response body)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json, text/json, application/xml, text/xml, application/x-www-form-urlencoded
 - **Accept**: Not defined

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

