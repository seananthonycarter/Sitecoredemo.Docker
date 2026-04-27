import { Placeholder } from '@sitecore-jss/sitecore-jss-nextjs';
import { ComponentProps } from 'lib/component-props';

const NewsMain = (props: ComponentProps): JSX.Element => (
  <div>
    <section className={'mb-[24px] xl:mb-[40px]'}>
      <Placeholder name={`pageheader`} rendering={props.rendering} />
    </section>
    <section>
      <Placeholder name={`pagemain`} rendering={props.rendering} />
    </section>
  </div>
);

export default NewsMain;
