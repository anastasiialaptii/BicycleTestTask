import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { BicycleComponent } from './bicycles/bicycle/bicycle.component';
import { BicycleService } from './shared/bicycle.service';
import { BicycleListComponent } from './bicycles/bicycle-list/bicycle-list.component';
import { FreeBicycleListComponent } from './bicycles/free-bicycle-list/free-bicycle-list.component';
import { TotalBisyclesPriceComponent } from './bicycles/total-bisycles-price/total-bisycles-price.component';
import { TotalBisyclesAmountComponent } from './bicycles/total-bisycles-amount/total-bisycles-amount.component';

@NgModule({
  declarations: [
    AppComponent,
    BicycleComponent,
    BicycleListComponent,
    FreeBicycleListComponent,
    TotalBisyclesPriceComponent,
    TotalBisyclesAmountComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    HttpClientModule
  ],
  providers: [BicycleService],
  bootstrap: [AppComponent]
})
export class AppModule { }
