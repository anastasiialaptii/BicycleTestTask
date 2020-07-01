import { Component, OnInit } from '@angular/core';
import { BicycleService } from 'src/app/shared/bicycle.service';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-bicycle',
  templateUrl: './bicycle.component.html',
  styles: []
})
export class BicycleComponent implements OnInit {

  constructor(public service: BicycleService) { }

  ngOnInit(): void {
    this.resetForm();
  }

  resetForm(form?: NgForm) {
    if (form != null)
      form.form.reset();
    this.service.formData = {
      Id: 0,
      Name: '',
      BicycleCategory: '',
      Price: null,
      IsRented: false
    }
  }

  onSubmit(form: NgForm) {
    if (this.service.formData.Id == 0)
      this.InsertBicycle(form);     
  }

  InsertBicycle(form: NgForm) {
    this.service.CreateBicycle().subscribe(
      res => {
       this.service.GetFreeBicycles();
       this.service.GetTotalBicyclesAmount();
       this.resetForm();
      },
      err => {
        debugger;
        console.log(err);
      }
    )
  }
}
