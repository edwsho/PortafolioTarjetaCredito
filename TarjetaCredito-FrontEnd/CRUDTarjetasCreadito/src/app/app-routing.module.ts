import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CreditCardComponent } from './Components/credit-card/credit-card.component';
import { HomeComponentComponent } from './Components/home-component/home-component.component';

/*
Anado los componentes al servicio de rutas de Angular dentro de esta constante
*/
const routes: Routes = [


  { path:'HomePage', component:HomeComponentComponent},
  { path:'CreditCard', component:CreditCardComponent},
  // { path:'Tablee', component:PageNotFounfComponent},
  // { path:'StudentsTable', component:StudentsComponent},
  // { path:'StaffTable', component:StaffComponent},
  { path: '**', redirectTo: '/HomePage' }


];
@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
