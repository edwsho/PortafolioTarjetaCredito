import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { SideBarComponent } from './Components/side-bar/side-bar.component';
import { HomeComponentComponent } from './Components/home-component/home-component.component';
import { CreditCardComponent } from './Components/credit-card/credit-card.component';

@NgModule({
  declarations: [
    AppComponent,
    SideBarComponent,
    HomeComponentComponent,
    CreditCardComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
