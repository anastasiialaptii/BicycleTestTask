import { Component, OnInit } from '@angular/core';
import { BicycleService } from 'src/app/shared/bicycle.service';

@Component({
  selector: 'app-total-bisycles-amount',
  templateUrl: './total-bisycles-amount.component.html',
  styles: [
  ]
})
export class TotalBisyclesAmountComponent implements OnInit {

  constructor(public service:BicycleService) { }

  ngOnInit(): void {
    this.service.GetTotalBicyclesAmount();
  }

}
