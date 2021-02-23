# Araç Kiralama Sistemi (Car Rental System) 
<p align="center">
<img src="https://st2.depositphotos.com/2172301/6557/v/950/depositphotos_65575193-stock-illustration-vector-template-of-car-rental.jpg"  alt="Araç Kiralama Sistemi (Rent A Car System)" width="400" height="400"/>

![](https://img.shields.io/github/stars/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/forks/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/tag/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/release/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/github/issues/zeynepmirayertunc/ReCapProject.svg) ![](https://img.shields.io/bower/v/editor.md.svg)

### *About*
- Bu proje, bir online eğitim platformu olan Kodloma.io'da [Engin Demiroğ](https://github.com/engindemirog) tarafından verilen "Yazılım Geliştirici Yetiştirme Kampı" için Tekrar ve geliştirme projesi (ReCapProject) olması amacıyla oluşturulmuştur. Proje, bir araba kiralama sistemi olup proje dili Türkçedir. 

- This project was created as a Recap project for "Software Developer Training Camp" given by [Engin Demirog](https://github.com/engindemirog) on Kodlama.io, an online education platform. The project is a car rental system and the project language is Turkish.
 
 
 <p> 
 <a href="https://www.kodlama.io/" target="_blank"> 
  <img src="https://process.fs.teachablecdn.com/ADNupMnWyR7kCWRvm76Laz/resize=width:705/https://www.filepicker.io/api/file/Zk7d1MdoSJ6cEShVbfd0" width="50" height="50"> Kodlama.io
  </a> &nbsp;

-----------------------
### *Kullanılan IDE* 
<p> 
 <a href="https://visualstudio.microsoft.com/tr/vs/" target="_blank"> 
<img src="https://upload.wikimedia.org/wikipedia/commons/thumb/5/59/Visual_Studio_Icon_2019.svg/1200px-Visual_Studio_Icon_2019.svg.png" width="25" height="25"> 
Visual Studio 2019
  </a> &nbsp;
 
----------------------------------------
### *Kullanılan Paketler*
- Microsoft.EntityFrameworkCore.SqlServer (3.1.11) -- [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac(6.1.0) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac.Extras.DynamicProxy(6.0.0) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- FluentValidation(9.5.1) -- [Business katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) ve [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde
- Autofac.Extensions.DependencyInjection(7.1.0) -- [Core katmanında](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/Core) olacak şekilde


---------------------------------------
### *SQL*
- Sql tablosu oluşturmak için --  [CarRentalProject.sql](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/CarRentalProject.sql)


Car                                                                                  
| Name       | Data type  |                                                                       
|------------------|------------- |             
| Id      | INT  |                 
| Name    | NVARCHAR(50)  |                                                           
| BrandId      | INT     |
| ColorId      | INT   |
| DailyPrice    | DECIMAL |
| ModelYear      | INT |
| Descriptions   | NVARCHAR(50) |

Colors 
| Name       | Data type  |  
|------------------|--------------------------|
| Id      | INT    |
| Name    | NVARCHAR(50)


<table>
<tr><th>Cars</th><th>Colors</th></th>Brands</th></tr>
<tr><td>

| Name  | Data type  |
|-------|-------------|
| Id      | INT  |                 
| Name    | NVARCHAR(50)  |                                                           
| BrandId      | INT     |
| ColorId      | INT   |
| DailyPrice    | DECIMAL |
| ModelYear      | INT |
| Descriptions   | NVARCHAR(50) |

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| Name    | NVARCHAR(50)

</td><td>
 
| Name       | Data type  |  
|------------|--------------|
| Id      | INT    |
| Name    | NVARCHAR(50) 

</td></tr> </table>

-----------------------------------


### *Güncellemeler*
- 16.02.2021 -- [WebAPI katmanı](https://github.com/zeynepmirayertunc/ReCapProject/blob/master/WebAPI) kuruldu :heavy_check_mark:
- 16.02.2021 -- [Business katmanındaki tüm servislerin](https://github.com/zeynepmirayertunc/ReCapProject/tree/master/Business/Abstract) [Api karşılığı](https://github.com/zeynepmirayertunc/ReCapProject/tree/master/WebAPI/Controllers) yazıldı :heavy_check_mark:
- 23.02.2021 -- Autofac desteği eklendi :heavy_check_mark:
- 23.02.2021 -- FluentValidation desteği eklendi :heavy_check_mark:
- 23.02.2021 -- AOP desteği eklendi :heavy_check_mark: 

  
  

