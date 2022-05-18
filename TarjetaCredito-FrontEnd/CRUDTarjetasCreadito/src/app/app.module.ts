import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideBarComponent } from './Components/side-bar/side-bar.component';
import { HomeComponentComponent } from './Components/home-component/home-component.component';
import { CreditCardComponent } from './Components/credit-card/credit-card.component';
import { ListaTarjetasCreditoComponent } from './Components/lista-tarjetas-credito/lista-tarjetas-credito.component';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    SideBarComponent,
    HomeComponentComponent,
    CreditCardComponent,
    ListaTarjetasCreditoComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserModule,
    FormsModule,
    ReactiveFormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
