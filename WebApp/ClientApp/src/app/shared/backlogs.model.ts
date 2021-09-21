import { Priorities } from "../utilities/priorities";

export class Backlogs {
  id: number= 0;
  title: string='';
  description: string = '';
  priority: Priorities;
  isActive: boolean = true;
  actionOn: Date = new Date();
}
