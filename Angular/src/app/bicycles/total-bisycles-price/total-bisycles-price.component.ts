import { Component, OnInit } from '@angular/core';
import { BicycleService } from 'src/app/shared/bicycle.service';

@Component({
  selector: 'app-total-bisycles-price',
  templateUrl: './total-bisycles-price.component.html',
  styles: [
  ]
})
export class TotalBisyclesPriceComponent implements OnInit {

  constructor(public service:BicycleService) { }

  ngOnInit(): void {
    this.service.GetTotalBicyclesPrice();
  }
}
