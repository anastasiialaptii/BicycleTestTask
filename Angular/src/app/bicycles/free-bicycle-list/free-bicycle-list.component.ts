import { Component, OnInit } from '@angular/core';
import { BicycleService } from 'src/app/shared/bicycle.service';

@Component({
  selector: 'app-free-bicycle-list',
  templateUrl: './free-bicycle-list.component.html',
  styles: [
  ]
})
export class FreeBicycleListComponent implements OnInit {

  constructor(public service: BicycleService) { }

  ngOnInit(): void {
    this.service.GetFreeBicycles();
    this.service.GetRentedBicycles();
  }

  onDelete(Id) {
    if (confirm('Are you sure to delete this record ?')) {
      this.service.DeleteBicycle(Id)
        .subscribe(res => {
          this.service.GetFreeBicycles();
          this.service.GetTotalBicyclesAmount();
        },
          err => {
            debugger;
            console.log(err);
          })
    }
  }

  onRent(Id) {
    this.service.RentBicycle(Id)
      .subscribe(res => {
        this.service.GetFreeBicycles();
        this.service.GetRentedBicycles();
        this.service.GetTotalBicyclesPrice();
        this.service.GetTotalBicyclesAmount();
      },
        err => {
          debugger;
          console.log(err);
        })
  }
}
