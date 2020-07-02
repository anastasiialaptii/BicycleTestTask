import { Bicycle } from './../../shared/bicycle.model';
import { BicycleService } from './../../shared/bicycle.service';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-bicycle-list',
  templateUrl: './bicycle-list.component.html',
  styles: []
})
export class BicycleListComponent implements OnInit {

  constructor(public service: BicycleService) { }

  ngOnInit(): void {
    this.service.GetRentedBicycles();

  }

  onCancelRent(id) {
    this.service.CancelRentBicycle(id)
      .subscribe(res => {
        this.service.GetRentedBicycles();
        this.service.GetFreeBicycles();
        this.service.GetTotalBicyclesPrice();
        this.service.GetTotalBicyclesAmount();
      },
        err => {
          debugger;
          console.log(err);
        })
  }
}
